namespace Solid
{
    public class Funcionario
    {
        public double SalarioBase { get; internal set; }
        public Cargo Cargo { get; set; }

        public Funcionario(double salarioBase, Cargo cargo)
        {
            SalarioBase = salarioBase;
            Cargo = cargo;
        }

        public double CalculaSalario()
        {
            return this.Cargo.Regra.Calcula(this);
        }
    }
}