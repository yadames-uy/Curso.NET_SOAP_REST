using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMiServicio" in both code and config file together.
[ServiceContract]
public interface IMiServicio
{
    [OperationContract]
    string Sumar(int a, int b, int c);
}