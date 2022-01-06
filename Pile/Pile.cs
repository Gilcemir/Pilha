namespace Pile;
public class MyPile
{
    //A pilha começa com um Objeto, que está sempre no TOPO. 
    //Não sei qual seria a boa prática para inicializar esse Obj com a pilha vazia...
    Obj topo;

    //Empilha;
    public void StackUp(object obj)
    {
        Obj obj1 = new Obj(this.topo, obj);
        this.topo = obj1;

    }


    //Desempilha.
    public object Unstack()
    {
        if(this.topo == null){
            throw new ArgumentException("Empty Stack!");
        }
        Obj obj1 = this.topo;
        this.topo = obj1.anterior;
        return obj1.atual;
    }

    //Imprimindo a pilha.
    public void print(){
        Obj Obj1 = this.topo;

        while(Obj1!= null){
            Console.WriteLine(Obj1.atual);
            Obj anterior = Obj1.anterior;
            Obj1 = anterior;
        }
    }


    //Toda pilha é uma pilha de um objeto. Aqui não quis especificar o tipo, sendo assim a pilha pode receber objetos de tipos diferentes.
    //Portanto, essa classe implementa o Objeto da pilha, que contem o objeto atual e um apontador para o anterior.
    public class Obj
    {
        public Obj anterior {get; set;} 
        public object atual {get; set;}

        public Obj(Obj anterior, object atual){
            this.atual = atual;
            this.anterior = anterior;
        }
    }

}
