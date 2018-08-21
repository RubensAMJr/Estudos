namespace Solid
{
    public abstract class Cargo
    {

        public IRegraDeCalculo Regra { get; private set; }

        protected Cargo(IRegraDeCalculo regra)
        {
            this.Regra = regra;
        }
    }
}