void PrintList<T>(LinkedList<T> list){

}

void PrintNode<T>(int count, Node<T> node){
	Console.Write("Data: ");
	Console.Write(node.Data);
	Console.WriteLine("-------------------");
}

var list = new LinkedList<string>();
list.insert(new Node<string>("Item 1", null));

PrintList<string>(list);

list.insert(new Node<string>("Item 2", list.head));
