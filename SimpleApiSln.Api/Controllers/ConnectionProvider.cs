using Microsoft.Extensions.Configuration;

public class ConnectionProvider 
{
    private IConfiguration _configuration;

    public ConnectionProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string GetConectionString()
    {
        return _configuration.GetConnectionString("Myconn");
    }
}