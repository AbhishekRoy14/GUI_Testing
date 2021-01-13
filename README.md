# GUI_Testing

Use C# as the programming language and Visual Studio as the development environment
to develop a GUI application that includes:
- an appropriate graphical user interface (GUI)
- selection of the input folder of the collection (files will be found in this folder and sub
folders)
- ability to read the collection and build the inverted index as described in the
supporting material. When adding terms to the inverted index, we apply the rules
below, in order:
- remove non-alphanumeric characters from each term
- ensure stop words are not added to the inverted index
- ensure the term is not added to the inverted index if the length of a term is more
than 10 characters
- use the implementation of porter stemmer as described in the link provided
to stem the term before it is added to the inverted index (https://tartarus.org/
martin/PorterStemmer/csharp.txt)


A GUI that:
- displays the total number of different words in the inverted index
- displays the average length of terms in the inverted index
- allows the user toenter a term to search, and the application will display the list
of files that contains a term
- includes a refresh button that can rebuild the inverted index using multithreading. While rebuilding the inverted index, the user gets an appropriate
message that the inverted index is not available.

##
