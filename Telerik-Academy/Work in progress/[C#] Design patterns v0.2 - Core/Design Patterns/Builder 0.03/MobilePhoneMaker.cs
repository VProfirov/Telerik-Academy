namespace Builder_0._03
{
    public class MobilePhoneMaker
    {
        private readonly MobilePhoneBuilder builder;

        public MobilePhoneMaker(MobilePhoneBuilder phoneBuilder)
        {
            builder = phoneBuilder;
        }

        public MobilePhone GetMobilePhone()
        {
            return builder.GetMobilePhone();
        }

        public void BuildMobilePhone()
        {
            builder.CreateMobilePhone();

            builder.AddSensors();
            builder.InstallOS();
        }
    }
}