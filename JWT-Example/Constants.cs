namespace JWT_Example
{
    public class Constants
    {
        //endpoint recieving the token
        public const string Audiance = "https://localhost:44310/";

        //endpoint providing the token, in this case the application
        public const string Issuer = Audiance;

        public const string Secret = "this_is_an_example_secret";
    }
}
