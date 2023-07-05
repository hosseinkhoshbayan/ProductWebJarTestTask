namespace ProductWebJarTask.Application.Exceptions;

public class NotFoundException:ApplicationException
{
    public NotFoundException(string name, object key) : base($"{name} ({key}) یافت نشد")
    {

    }
}