// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MiServicio" in code, svc and config file together.
public class MiServicio : IMiServicio
{
    public string Sumar(int a, int b, int c)
    {
        return string.Format("La suma es {0}", a + b + c);
    }
}