namespace Exercicio5
{
    internal class Aluno
    {
        public string Nome;
        public double PrimeiraNota, SegundaNota, TerceiraNota;

        public double NotaFinal() 
        { 
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}