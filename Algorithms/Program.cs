void PrintList<T>(DoublyLinkedList<T> list){
	Console.WriteLine($"Count: {list.Count}");
	var head = list.Head;
	if(head is not null)
		PrintNode(head);
}
void PrintListReverse<T>(DoublyLinkedList<T> list){
	var tail = list.Tail;
	if(tail is not null)
		PrintNodeReverse(tail);
}

void PrintNode<T>( Node<T> node){
	Console.Write("Data: ");
	Console.WriteLine(node.Data);
	Console.WriteLine("-------------------");
	if(node.Next != null)
		PrintNode(node.Next);
}

void PrintNodeReverse<T>( Node<T> node){
	Console.Write("Data: ");
	Console.WriteLine(node.Data);
	Console.WriteLine("-------------------");
	if(node.Prev != null)
		PrintNodeReverse(node.Prev);
}


var list = new DoublyLinkedList<string>();
list.InsertAtStart("Item2");
list.InsertAtStart("Item1");
list.InsertAtEnd("Item3");

PrintListReverse<string>(list);
