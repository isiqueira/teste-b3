namespace TesteB3.Models
{
    public class CdbModel
    {
        private double cdi;
        private double taxaBanco;


        public CdbModel(double valorInicial, double cdi, double taxaBanco, int meses)
        {
            if (valorInicial <= 0)
                throw new ArgumentException("O Valor inicial deve ser positivo");

            if (meses <= 1)
                throw new ArgumentException("a quantidade de meses deve ser maior que 1");

            ValorInicial = valorInicial;
            Cdi = cdi;
            TaxaBanco = taxaBanco;
            Meses = meses;
        }


        //VF
        public double ValorFinal 
        {
            get 
            {
                var valorFinal = 0.0;
                for (int i = 0; i < Meses; i++)
                {
                    var _ = Calculate(i == 0 ? ValorInicial : valorFinal);
                    valorFinal = _;
                }
                return valorFinal;
            }
        }

        //VI
        public double ValorInicial { get; set; }

        public double Cdi
        {
            get => cdi;
            set => cdi = value / 100;
        }
        //TB
        public double TaxaBanco
        {
            get => taxaBanco;
            set => taxaBanco = value / 100;
        }

        public double ValorLiquido 
        { 
            get
            {
                var percentualImposto = 0.0;
                
                if (Meses <= 6)
                    percentualImposto = 0.225;
                else if (Meses > 6 && Meses <= 12)
                    percentualImposto = 0.20;
                else if (Meses > 12 && Meses <= 24)
                    percentualImposto = 0.175;
                else
                    percentualImposto = 0.15;
                
                return  ValorFinal - ( Ganho * percentualImposto);
            }
        }

        public double Ganho 
        {
            get => ValorFinal - ValorInicial; 
        }

        public int Meses { get; set; }


        public double Calculate(double valor) =>
            valor * (1 + (cdi * taxaBanco));
    }
}
