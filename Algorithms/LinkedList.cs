internal class LinkedList<T>{
	internal Node<T> head;

	internal void insert(Node<T> item){
		if(head==null){
			head = item;
			return;
		}

		item.Next = head;
		head = item;
	}
}

internal class Node<T>{
	internal Node(T data, Node<T> next){
		this.Data = data;
		this.Next = next;
	}
	internal T Data;
	internal Node<T> Next;
	
}
