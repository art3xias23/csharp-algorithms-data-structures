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


        while (currentItem.Next is not null)
        {
            currentItem = currentItem.Next;
        }
        currentItem.Next = item;
    }

    internal void deleteFirstByValue(T data)
    {

        if (Head == null)
        {
            return;
        }
	Node<T> prevItem = null;
        var item = Head;
        while (item is not null){
		if(item.Data.Equals(data)){
			if(prevItem == null){
				Head = item.Next;	
				return;
			}

			prevItem.Next = item.Next;
			return;
		}
		prevItem = item;
		item = item.Next;
	}

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
