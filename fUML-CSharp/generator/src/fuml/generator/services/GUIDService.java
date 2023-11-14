package fuml.generator.services;

public class GUIDService
{
	public String getGUID()
	{
		return java.util.UUID.randomUUID().toString().toUpperCase();
	}
}
