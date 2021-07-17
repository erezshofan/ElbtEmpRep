# Elbit Employee Rep

This project is a asp.net core project based on angular2 and MVC.
The project made on VS 2019

## How to install the project

1\. Clone the repository:

```
git clone https://github.com/erezshofan/ElbtEmpRep.git
```

2\. Launch the project:

```bash
Go to \ElbtEmpRep\‏‏ElbitEmployeesRep and open ElbitEmployees.sln
```

3\. Restore packages :

```
Go to ClientApp folder in the project.
open it in cmd and run "npm install"
```

4\. Execute the app :

```
Clean and rebuild the solution and start the project to see the live app
```

## What’s in the repo

This repo includes the source code of _‏‏ElbitEmployeesRep_. The app has the following structure:

```

ElbitEmployees
	Common					// Common project files like Entities	
		Entities 			// Employee Entity of the project , server side
		Helper 				// TextDbHelper - File helper managment , server side
	ClientApp				// client application
		src
			app				// client app
				Entities	// entities client side
				Services	// services from client to the controllers server
				components  // ** Components that get rendered into the page (HTML, CSS and TS files) **
				app.module.ts	// components definitions
			index.html		// The initial html page
	Controllers				// server side MVC controllers
			
.gitignore
README.md

```
