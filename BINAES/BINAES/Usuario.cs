using System.Windows.Forms;

namespace BINAES
{
    public class Usuario
    {
            public string iduser { get; set; }
            public string nombreusuario { get; set; }
            public string contraseña { get; set; }
            public string nombre { get; set; }
            public PictureBox fotografia { get; set; }
            public string email { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string idInstitucion { get; set; }
            public string idOcupacion { get; set; }

            public Usuario()
            {
                this.iduser = "";
                this.nombreusuario = "";
                this.contraseña = "";
                this.nombre = "";
                this.fotografia = null;
                this.email = "";
                this.direccion = "";
                this.telefono = "";
                this.idInstitucion = "";
                this.idOcupacion = "";
            }

            public Usuario(string Iduser,string Nombreusuario,string Contraseña, string Nombre, PictureBox Fotografia,string Email,string Direccion,string Telefono, string IdInstitucion,string IdOcupacion)
            {
                iduser = Iduser;
                nombreusuario = Nombreusuario;
                contraseña = Contraseña;
                nombre = Nombre;
                fotografia = Fotografia;
                email = Email;
                direccion = Direccion;
                telefono = Telefono;
                idInstitucion = IdInstitucion;
                idOcupacion = IdOcupacion;
            }
        
    }
}