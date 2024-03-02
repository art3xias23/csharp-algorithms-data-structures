void PrintList<T>(LinkedList<T> list){
	var head = list.Head;
	PrintNode(head);
}

void PrintNode<T>( Node<T> node){
	Console.Write("Data: ");
	Console.WriteLine(node.Data);
	Console.WriteLine("-------------------");
	if(node.Next != null)
		PrintNode(node.Next);
}

Console.WriteLine("Helo");

var list = new LinkedList<string>();
list.insertAtStart(new Node<string>("Item 2"));

list.insertAtEnd(new Node<string>("Item 3"));
list.insertAtEnd(new Node<string>("Item 4"));
list.insertAtEnd(new Node<string>("Item 5"));
list.insertAtStart(new Node<string>("Item 1"));
PrintList<string>(list);
