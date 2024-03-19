namespace Strong_Fit.Models
{
    public class Treino
    {
        public int TreinoID { get; set; }
        public int PersonalID { get; set; }
        public int AlunoID { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
    }
}
