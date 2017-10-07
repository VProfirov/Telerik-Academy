namespace Factory_Pattern
{
    public class NullAuto:IAuto
    {
        public void TurnOn()
        {
            throw new System.NotImplementedException();
        }

        public void TurnOff()
        {
            throw new System.NotImplementedException();
        }
    }
}