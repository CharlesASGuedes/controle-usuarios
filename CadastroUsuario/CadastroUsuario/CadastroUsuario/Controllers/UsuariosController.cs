using CadastroUsuario.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace CadastroUsuario.Controllers
{
    public class UsuariosController : ApiController
    {
        private CadastroUsuarioDataContext db = new CadastroUsuarioDataContext();

        // GET: api/Usuarios
        public IQueryable<Usuario> GetUsuarios()
        {
            return db.Usuarios;
        }

        // GET: api/Usuarios/5
        public HttpResponseMessage GetUsuario(string id)
        {
            try
            {
                Usuario usuario = db.Usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario == null)
                    throw new Exception("Cliente não encontrado");

                return Request.CreateResponse(HttpStatusCode.OK, usuario);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // POST: api/Usuarios
        [Route("cadastrar")]
        public HttpResponseMessage PostUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid | usuario == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            if (EmailExists(usuario.Email))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "E-mail " + usuario.Email + " já existente");
            }

            if (!Salvar(usuario))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Usuário " + usuario.Nome + " já cadastrado!");
            }

            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        // PUT api/Usuarios/5
        public HttpResponseMessage PutUsuario(string id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != usuario.Id)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            usuario.Data_Atualizacao = DateTime.Now;
            usuario.Data_Criacao = DateTime.Now;
            usuario.Ultimo_Login = DateTime.Now;
            db.Entry(usuario).State = EntityState.Modified;

            try
            {                
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST: api/Usuarios/Login
        [HttpPost]
        [Route("login")]
        public HttpResponseMessage PostLogin(Usuario usuario)
        {
            try
            {
                var usuarioCompleto = ValidarEmailSenha(usuario);
                if (usuarioCompleto == null)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Usuário e/ou senha inválidos");
                }

                return Request.CreateResponse(HttpStatusCode.OK, usuarioCompleto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }                                   
        }

        private bool EmailExists(string email)
        {
            return db.Usuarios.Count(u => u.Email == email) > 0;
        }

        private bool Salvar(Usuario usuario)
        {
            var cadastrado = false;
            try
            {
                usuario.Data_Criacao = DateTime.Now;
                usuario.Data_Atualizacao = DateTime.Now;
                usuario.Ultimo_Login = DateTime.Now;

                db.Usuarios.Add(usuario);
                db.SaveChanges();
                cadastrado = true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
            return cadastrado;
        }

        private Usuario ValidarEmailSenha(Usuario usuario)
        {
            var usuarios = db.Usuarios.FirstOrDefault(u => u.Email == usuario.Email && u.Senha == usuario.Senha);

            return usuarios;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}