internal class DoublyLinkedList<T>
{
    private Node<T> head { get; private set; }
    private Node<T> tail { get; private set; }
    private int count;
    public int Count => count;


    void InsertAtStart(T data)
    {
        if (head == null)
        {
            head = new Node<T>(data);
            tail = new Node<T>(data);
        }
        else
        {

            var temp = head;
            temp.Next = head;
            head = temp;
        }
	count++;


    }

    void insertAtEnd(T data){
	    if(tail == null){
		    tail = new Node<T>(data);
	    }
	    else{
		    var temp = tail;
		    temp.Prev = tail;
		    tail = temp;
	    }
	    count++;
    }

    void insertAtPosition(int pos, T data){
	    var c = 0;
	    Node<T> currentItem = null;
	    if(pos ==0){
		    InsertAtStart(data);
		    return;
	    }


	    // Closer to the start
	    if(pos  < Count - pos){
		while(currentItem is not null){
			if(c == pos){

			}
		}
	    }
	    // Closer to the end 
	    else{

	    }
	    while(currentItem is not null){
		if(currentItem.Next is null){
			insertAtEnd(data);
			return;
		}
		if(count == pos){
			var newNode = new Node<T>(data);
			currentItem
		}
	    }


    }

    void Delete(int pos)
    {

    }

    void Delete(T Data)
    {

    }

    void Traverse(bool forward = true)
    {

    }

    Node<T> Find(T Data)
    {

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
