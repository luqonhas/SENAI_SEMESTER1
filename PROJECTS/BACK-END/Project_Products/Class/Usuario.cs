using System;

namespace Project_Products.Class
{
    public class Usuario
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public Usuario(){
            Cadastrar();
        }
        public void Cadastrar(){
            Name = "Lucas";
            Email = "lucas.apolinario98@gmail.com";
            Password = "12345";
            RegistrationDate = DateTime.Now;
        }
        public void Deletar(){
            Name = "";
            Email = "";
            Password = "";
            RegistrationDate = DateTime.Parse("");
        }
    }
}