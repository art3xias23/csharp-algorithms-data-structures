void PrintList<T>(LinkedList<T> list){
	var head = list.Head;
	if(head is not null)
		PrintNode(head);
}

void PrintNode<T>( Node<T> node){
	Console.Write("Data: ");
	Console.WriteLine(node.Data);
	Console.WriteLine("-------------------");
	if(node.Next != null)
		PrintNode(node.Next);
}

Console.WriteLine("Hello");

var list = new LinkedList<string>();
list.insertAtStart(new Node<string>("Item3"));
list.insertAtStart(new Node<string>("Item2"));
list.insertAtStart(new Node<string>("Item1"));
list.deleteFirstByValue("Item1");

PrintList<string>(list);
