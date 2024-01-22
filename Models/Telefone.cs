namespace webAPI.Models
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public string TelefoneDescricao { get; set; }
        public String TelefoneNumero { get; set; }
        public int? PessoaID {  get; set; }  
        public virtual Pessoa? pessoa { get; set; }
    }
}
