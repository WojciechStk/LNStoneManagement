HELP PAGE

Below is a short description explaining what is in the application and what you need to run smoothly.

Table of Contents:

1. Home page
2. Additional menu
3. Gallery
4. Calculator
5. Database
7. Socialmedia
8. Websites
9. Other information

1. Home page

At the moment, the home page is only a showcase. Perhaps some specific functions will be found here in the future.

The most important information:
- in the upper left corner of the program there is a button (three lines) to expand the Main Menu,
where we can navigate to specific pages in the program, such as:
- Homepage
- Gallery
- Calculator
- Database
- Help
- in the upper right corner of the program there is a button (three dots) to expand the Additional Menu, where we can navigate to specific pages or functions in the program, such as:
- Instagram
- Shops
- About program
- Resize the window
- Close it


2. Gallery

In the gallery, we can view ready-made jewelry. Thanks to the navigation buttons under the photos, we have the ability to freely browse photos forward and backward.

3. Calculator

A calculator is some form of invoice. When there is already an item in the database, you can add it here by clicking on the drop-down list. After selecting an item by its name, the data assigned to it, such as "Diameter", "Price per stone", "Faceting", or "Store", are retrieved from the database and inserted into the appropriate fields.

The only value we choose ourselves is "Quantity", that is the amount of a given material (implicitly a given jewelery stone).

Function buttons (from the top):

- Calculate

After selecting "Quantity" and pressing the "Calculate" button, we will get the "Total Price" for the previously selected item, and if we have selected more items - I will summarize them.

The situation is similar when selecting the "Margin" amount - all amounts add up and we get the "Sum" result.

- Clear

The button for clearing the form returns it to its initial state.

- Print

Button for printing a previously completed page, e.g. for archiving.

A large text field at the bottom of the page is used to write notes, it can be especially useful in the case of a large number of materials inserted, or comments on the quality of products.



4. Database

The database page in the upper part contains fields for adding new items (you cannot leave blank fields). In the central part, we have an operation notification window, which informs us, for example, whether the saving to the database was successful. At the bottom of the page, we have a preview of the database itself with a search function and function buttons.

After filling in the fields of the new item

Function buttons (from the top):

- Save

Footnote used to write down the subject previously completed above. For the record, the most important thing is to assign a numeric identifier "Id", which cannot be overwritten with another element added later (exception: "Update").

- Search

Button for searching an item by its "Id" identifier. After entering the required "Id" in the "Enter Id" field, press the "Search" button and the program itself fills in the empty fields with data. This function is mainly used to update the data of an element (see: "Update").

- Update

Button for updating an item in the database. When we call the element using "Search" through "Id", we can make changes in other fields (except for the "Id" number - this one remains unchanged). When we make changes, the "Update" button will update this element in the database with the changed data.

- Basket

Button for deleting an item. After calling an item via "Id" (see: "Search"), we can use this button to remove it from the database.
Attention! Once an item has been deleted from the database, it cannot be restored to it.
Attention! At the moment, unfortunately, there is a "hole" in the "Id" after removing the item, an update should be released soon.

- Clear

The button for clearing the fields of a new element returns it to its initial state.

Search Bar:

There is a so-called "Search bar" above the database. Thanks to it, after entering any string of characters from the name of the element, it will be highlighted in yellow in the database.

5. Socialmedia

A page containing an embedded Instagram profile.

6. Websites

A page with buttons that open individual pages about home jewelry.

7. Other information

Attention!

- for the correct operation of the "Instagram" and "Stores" pages, the Microsoft Edge browser, updated to the latest version, must be installed on your computer. Furthermore, it is necessary to install WebView2 Runtime.

- for the correct operation of the database it is necessary to set the local server in "App.config" (data source = DESKTOP - ####### \ MYSQLSERVER1).

// EntityFramework, Version = 6.0.0.0
// SupportedRuntime version = "v4.0" sku = ". NETFramework, Version = v4.8"
