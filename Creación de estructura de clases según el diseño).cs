
public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }

    public MiembroDeLaComunidad(string nombre)
    {
        Nombre = nombre;
    }
}


public class Empleado : MiembroDeLaComunidad
{
    public decimal Salario { get; set; }

    public Empleado(string nombre, decimal salario) : base(nombre)
    {
        Salario = salario;
    }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Matricula { get; set; }

    public Estudiante(string nombre, string matricula) : base(nombre)
    {
        Matricula = matricula;
    }
}


public class ExAlumno : MiembroDeLaComunidad
{
    public int AnoGraduacion { get; set; }

    public ExAlumno(string nombre, int anoGraduacion) : base(nombre)
    {
        AnoGraduacion = anoGraduacion;
    }
}


public class Docente : Empleado
{
    public string Asignatura { get; set; }

    public Docente(string nombre, decimal salario, string asignatura) : base(nombre, salario)
    {
        Asignatura = asignatura;
    }
}

public class Maestro : Docente
{
    public Maestro(string nombre, decimal salario, string asignatura) : base(nombre, salario, asignatura)
    {
    }
}


public class Administrativo : Empleado
{
    public string Departamento { get; set; }

    public Administrativo(string nombre, decimal salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }
}

public class Administrador : Administrativo
{
    public Administrador(string nombre, decimal salario, string departamento) : base(nombre, salario, departamento)
    {
    }
}
