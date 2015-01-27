# Exercises.Day6

Exercises and solutions for the sixth day.

## 25. A little picture viewer

Use the `PictureBox` control, a `ComboBox` and a `FolderBrowserDialog` to create a simple application, which lets a user open a certain directory. All images of the selected directory (the following types are enough: png, gif, jpg, bmp) should be displayed in the combobox. Once the selected index of the combobox changes, the picture behind the selected item should be displayed in the picturebox.

As a little extra work you can try to implement a zoom and rotate operation.

## 26. Loading and saving notes

Nowadays really simple note apps seem to be in fashion again. Write a small program that uses your own class called `Note`. An instance of `Note` contains a creation date, a last update date, a priority enumeration value (think about good values in this enumeration), a title, remark and description, as well as a due date. Dates should be saved as `DateTime`.

The application should be able to create new note instances, load existing notes from the file system and save notes to the file system. Use the `XmlSerializer` for loading and saving instances of the `Note` class. Use the `DateTimePicker` as the control for any `DateTime` value.

*Hint* Using the dialoges called `OpenFileDialog` and `SaveFileDialog` will help a lot.

## 27. Dynamic programming and webrequests

Create a method to read out XML files that have been placed on some webserver. In the first stage the content (XML) should be received. Afterwards, create a new instance of `XmlDocument` as a `dynamic` type.

Show that you can actually access the member of the XML document dynamically, i.e. that the following lines of code,

    var document = new XmlDocument("...");
    var element = document.GetElement("root").GetElement("child");

could be replaced by the following code (in case of an XML document with a root node called root and a child node called child):

    dynamic document = new XmlDocument("...");
    var element = document.root.child;

Show that `object`, `var` and `dynamic` are three different things.

The URL of a sample XML document is <a href="https://raw.githubusercontent.com/CSharpLecture/Samples/master/Books.xml">https://raw.githubusercontent.com/CSharpLecture/Samples/master/Books.xml</a>.

## 28. Events

Extend the custom user control (exercise 20) with some events called

* **Started**,
* **Stopped**, passing the passed time and the reason (button pressed or time over) in the event arguments and
* **Updated**, passing the current time in the event arguments.

Create an event-handler for the `Updated` event in the code-behind (no-designer) and update the name of the form with the given information.

## 29. A simple paint program

Create a Windows Forms application that consists of a `PictureBox` control. Once the user presses the left mouse button a line is drawn.

Additionally integrate some buttons that let the user choose a color and thickness for drawing a line. Think about how you could implement drawing helpers like drawing rectangles, ellipses and more.

## License
This work is licensed under a [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License](http://creativecommons.org/licenses/by-nc-sa/4.0/).