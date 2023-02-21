using EnumFlags;

static void CanWrite(Operation operation){
    if(operation.HasFlag(Operation.Write)){
        Console.WriteLine("Writing...");
    } else {
        Console.WriteLine("Cannot Write...");
    }
}

static void CanRead(Operation operation){
    if(operation.HasFlag(Operation.Read)){
        Console.WriteLine("Reading...");
    } else {
        Console.WriteLine("Cannot Read...");
    }
}

var operations = Operation.Read;

CanWrite(operations);
CanRead(operations);

//verifica se existe o valor para Write, se não adiciona
operations |= Operation.Write;
CanWrite(operations);

//removendo a permissão Write
operations &= ~Operation.Write;
CanWrite(operations);

//o valor 0 é um caso especial que se deve comparar com o próprio enum
Console.WriteLine(operations.HasFlag(Operation.None));
//mesmo o valor None não ter sido acumulado a operação retorna true

//a forma correta é comparando diretamente ao enum
Console.WriteLine(operations == Operation.None);