internal class DoublyLinkedList<T>
{
    internal Node<T> Head { get; private set; }
    internal Node<T> Tail { get; private set; }
    private int count;
    public int Count => count;


    internal void InsertAtStart(T data)
    {
        if (Head == null)
        {
            Head = new Node<T>(data);
            Tail = new Node<T>(data);
        }
        else
        {

            var newNode = new Node<T>(data);
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
	    SetTail(Head);
        }
        count++;


    }

    private void SetHead(Node<T> node){
	    if(node == null) return;

	    while(node.Prev is not null){
		    node = node.Prev;
	    }
	    Head = node;
    }

    private void SetTail(Node<T> node){
	    if(node == null) return;

	    while(node.Next is not null){
		    node = node.Next;
	    }
	    Tail = node;
    }

    internal void InsertAtEnd(T data)
    {
        if (Tail == null)
        {
                var newNode = new Node<T>(data);
            if (Head == null)
            {
               Head = newNode; 
            }

            Tail = newNode; 
        }
        else
        {
            var newNode = new Node<T>(data);
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
	    SetHead(Tail);
        }
        count++;
    }

    internal void InsertAtPosition(int pos, T data)
    {
        var c = 0;
        Node<T> currentItem = null;
        if (pos == 0)
        {
            InsertAtStart(data);
            return;
        }


        // Closer to the start
        if (pos < Count - pos)
        {
            while (currentItem is not null)
            {
                if (c == Count - pos)
                {
                    var newNode = new Node<T>(data);
                    newNode.Next = currentItem;
                    newNode.Prev = currentItem.Prev;
                    currentItem.Prev = newNode;
                    return;
                }
                // Closer to the end 
                else
                {
                    currentItem = currentItem.Next;
                    c++;
                }
            }
        }
        else
        {
            while (currentItem is not null)
            {
                if (c == pos)
                {
                    var newNode = new Node<T>(data);
                    newNode.Next = currentItem;
                    newNode.Prev = currentItem.Prev;
                    currentItem.Prev = newNode;
                    return;
                }
                // Closer to the end 
                else
                {
                    currentItem = currentItem.Prev;
                    c++;
                }
            }
        }
    }


    internal void Delete(int pos)
    {

    }

    internal void Delete(T Data)
    {

    }

    internal void Traverse(bool forward = true)
    {

    }

    Node<T> Find(T data)
    {
        return new Node<T>(data);
    }
}

internal class Node<T>
{
    internal Node(T data)
    {
        Data = data;
    }

    internal Node<T> Next { get; set; }

    internal Node<T> Prev { get; set; }

    internal T Data { get; }
}
