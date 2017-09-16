namespace Builder_0._03
{
    public abstract class MobilePhoneBuilder
    {
        protected readonly MobilePhone phone;
        //ctor if he has to init something specific }else{ use def prop init
        public abstract void InstallOS();
        public abstract void AddSensors();
    }
}