using Memento;

var editor = new TextEditor();
var history = new History();

editor.Write("Hello");
history.Save(editor.Save());

editor.Write("Hello World");
history.Save(editor.Save());

editor.Write("Hello World!!!");

Console.WriteLine($"Current: {editor.Text}");

var previous = history.Undo();
editor.Restore(previous);

Console.WriteLine($"Undo #1: {editor.Text}");

previous = history.Undo();
editor.Restore(previous);

Console.WriteLine($"Undo #2: {editor.Text}");