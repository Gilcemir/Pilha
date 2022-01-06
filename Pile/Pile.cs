namespace Pile;
public class MyPile
{
    Obj topo;

    public void StackUp(object obj)
    {
        Obj obj1 = new Obj(this.topo, obj);
        this.topo = obj1;

    }

    public object Unstack()
    {
        if(this.topo == null){
            throw new ArgumentException("Empty Stack!");
        }
        Obj obj1 = this.topo;
        this.topo = obj1.anterior;
        return obj1.atual;
    }


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
