namespace Fiap.Web.App.Model
{
    public class Media
    {

        public float Media1 { get; set; }
        public float Media2 { get; set; }
        public float MediaTotal { get; set; }

        public float CalculaMedia() 
        {
            MediaTotal = (Media1 + Media2) / 2;
            return MediaTotal;
        }

        public bool ValidacaoAprovacao(float MediaTotal)
        {
            if (MediaTotal > 6) {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
