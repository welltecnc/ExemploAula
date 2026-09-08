namespace ExemploAula
{
    class Estacao
    {
        //PROPRIEDADES (ATRIBUTOS)

        public string Motorista { get; set; }
        public double CapacidadeKwh {get;set;}
        public double  PorcentagemAtual { get; set; }
        public double PotenciaKW { get; set; }

        // MÉTODOS (AÇÕES)
        public double CalcularKwhNecessarios()
        {
            double porcetagem = (100.00 - PorcentagemAtual) / 100.00;
            return CapacidadeKwh * porcetagem;
        }

    }
}
