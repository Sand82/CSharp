using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ObjectInspector;

public static class Inspector
{
    public static void Print(object obj)
    {
        var objInfo = obj.GetType();

        PrintTitle("Object Type", 10);
        GetObjectInfo(objInfo);

        PrintTitle("Object Constructors");
        GetConstructorInfo(objInfo);

        PrintTitle("Object Properties");
        GetPropertiesInfo(objInfo, obj);

        PrintTitle("Object Fields", 15);
        GetFieldsInfo(objInfo, obj);

        PrintTitle("Object Fields", 15);
        GetMethods(objInfo, obj);

        PrintTitle("Object Interfaces", 15);
        GetInterfaces(objInfo);

        PrintTitle("Get custom attributes", 25);
        GetCustomAttributes(objInfo, obj);
    }

    private static void GetCustomAttributes(Type objInfo, object obj)
    {
        var attribute = objInfo.GetCustomAttribute<AgeAttribute>();

        int value = attribute.Age;

        var ageSeter = objInfo.GetProperty("Age");

        ageSeter.SetValue(obj, value);        
    }

    private static void GetInterfaces(Type type)
    {
        var interfaces = type.GetInterfaces();

        foreach (var item in interfaces)
        {
            Console.WriteLine(item.Name);

            var members = item.GetMembers();


            foreach (var item1 in members)
            {
                Console.WriteLine(item1.Name);
            }
        }
    }

    private static void GetMethods(Type objInfo, object obj)
    {
        var defaultMethods = new object()
            .GetType()
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        var methods = objInfo
            .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
            .Where(x => !x.IsSpecialName && !defaultMethods.Any(y => x.Name == y.Name))            
            .ToArray();

        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        PrintTitle("Assign private method value and execute it.", 40);

        var privateMethods = objInfo
            .GetMethod("WorkingCompany", BindingFlags.Instance | BindingFlags.NonPublic);

        var personTwo = new Person();

        object[] parameters = { "newCompany" };

        object result = privateMethods.Invoke(personTwo, parameters );        

        Console.WriteLine(result);

    }

    private static void GetFieldsInfo(Type objInfo, object obj)
    {
        var fields = objInfo
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(f => !f.IsDefined(typeof(CompilerGeneratedAttribute), false));
            //.Where(x => !x.Name.Contains("k__BackingField"));            

        foreach (var field in fields)
        {            
            Console.WriteLine($"{field.Name} : {field.GetValue(obj)}");                       
        }
    }    

    private static void GetPropertiesInfo(Type objInfo, object obj)
    {
        var properties = objInfo.GetProperties();

        var sb = new StringBuilder();

        foreach (var property in properties)
        {
            if (property.GetIndexParameters().Length == 0)
            {
                sb.AppendLine($"{property.Name} : {property.PropertyType.Name} = {property.GetValue(obj)}");                
            }            
        }

        Console.Write(sb.ToString());
    }

    private static void GetObjectInfo(Type objInfo)
    {
        Console.WriteLine(objInfo.Name);
        Console.WriteLine(objInfo.Namespace);
        Console.WriteLine(objInfo.BaseType);
    }

    private static void GetConstructorInfo(Type objInfo)
    {
        var constructors = objInfo.GetConstructors();

        foreach (var constructor in constructors)
        {
            var consParametersType = new Dictionary<string, string>();
            var parameters = constructor.GetParameters();

            foreach (var param in parameters)
            {
                consParametersType[param.Name!] = (param.ParameterType.Name);
            }

            var sb = new StringBuilder();
            sb.Append($"{constructor.ReflectedType!.Name}");
            sb.Append($"(");
            var count = 0;

            foreach (var item in consParametersType)
            {
                sb.Append($"{item.Value.ToLower()} {item.Key}");
                count++;
                if (count < consParametersType.Count)
                {
                    sb.Append(", ");
                }
            }
            sb.Append($")");

            Console.WriteLine(sb.ToString());
        }
    }

    private static void PrintTitle(string title, int delimitersCount = 20)
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', delimitersCount));
        Console.WriteLine(title);
        Console.WriteLine(new string('*', delimitersCount));
    }
}
