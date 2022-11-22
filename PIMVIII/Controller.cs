using System;


namespace PIMVIII
{
    public class Controller
        {
        public Controller() { }
        public Controller(int pId) => id = pId;
        protected int id { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public Endereco endereco { get; set; }
        public Telefone[] telefones { get; set; }

    }
}
