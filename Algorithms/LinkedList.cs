internal class LinkedList<T>
{
    internal Node<T> Head;

    internal void insertAtStart(Node<T> item)
    {
        if (Head == null)
        {
            Head = item;
            return;
        }

        item.Next = Head;
        Head = item;
    }

    internal void insertAtEnd(Node<T> item)
    {
        if (Head == null)
        {
            Head = item;
            return;
        }

	var currentItem = Head;	


	while(currentItem.Next is not null){
		currentItem = currentItem.Next;
	}
	currentItem.Next = item;
    }
}

internal class Node<T>
{
    internal Node(T data)
    {
        this.Data = data;
    }
    internal T Data;
    internal Node<T> Next;

}
