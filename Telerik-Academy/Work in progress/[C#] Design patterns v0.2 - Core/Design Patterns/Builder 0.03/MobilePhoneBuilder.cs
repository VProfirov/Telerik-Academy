namespace Builder_0._03
{
    public abstract class MobilePhoneBuilder
    {
        protected MobilePhone phone;
        //ctor if he has to init something specific }else{ use def prop init

        public void CreateMobilePhone()
        {
            phone = new MobilePhone();
        }

        public MobilePhone GetMobilePhone()
        {
            return phone;
        }

        public abstract void InstallOS();
        public abstract void AddSensors();
    }
}