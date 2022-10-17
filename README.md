# 🔐 Muragala Password Manager (C# GUI Application)
![Poster](https://user-images.githubusercontent.com/46389631/170724038-d95d0555-cb9e-46ec-9d88-66a7c5d366d3.png)

---

        NOTICE:
        I will continue to improve ths library and CLI program as well. Make sure to check out the
        Python edition as well as it is the main program.
        
*Links: [Password Manager Python](https://github.com/asankaSovis/password-manager-Python), [Password Manager C# CLI and Library](https://github.com/asankaSovis/password-manager-CSharpLibrary)*

Muragala is a password manager designed to make managing passwords easy and secure. My goal is to make it a secure and reliable password manager available in the public domain for everyone to use. Privacy and security is for everyone, this is the core value behind this project. It uses [Fernet encryption](https://github.com/thangchung/fernet-dotnet) to encrypt passwords and store them on a database. It uses two factor authentication with a password and randomly generated salt to encrypt the database. The application is built to be as simple as possible to make sure it's secure. On the other hand, this project is an experiment to see how to make a better security application.

Please note that I am still learning and this project has also been a way to expand my knowledge. Any suggestions, issues and ideas are more than welcome. On the other hand, this application is still in its alpha phase. Therefore please don't use it solely for personal usage. It might have severe bugs and issues regarding functionality and security.

## Dependencies
- [Muragala C# Library](https://github.com/asankaSovis/password-manager-CSharpLibrary) - This module is the core of the application.

## Download and Installation
Download the latest build from the *Releases* or the *releases* folder. Double click to open the installer. Click on the `Yes` button if Administrator priviledges are requested. Click on `I accept the agreement` and select `Next` to move forward. Tick `Create desktop shortcut` if you want a desktop shortcut to be created and click `Next`. Click `Install` to proceed with the installation. Wait until the installation completes. Tick `Launch Muragala Password Manager` if you want the application to open right away and click `Finish`.

> ![Installer Screenshot](https://user-images.githubusercontent.com/46389631/196189412-7b606c2d-adc8-493e-98b8-5a8eded21d1d.png)
> 
> Installer Screenshot

## Initial Setup
When application is opened for the first time, the application will request you to setup a new database. In order to proceed, you must enter a new password. In order to proceed, the password must be at least **Normal**. 

**NOTE: Make sure to remember this password as in order to decrypt the database, you are required to have the salt and password with you. In addition to this, you can also backup the credential file in case of an emergency. How to will be discussed below in *.**

> ![Password Setup](https://user-images.githubusercontent.com/46389631/196191190-450cb8fc-79eb-4041-ac4e-c5938ea91e9a.png)
> 
> Password Setup

## Usage

### 01. Opening the Application

Everytime you start the application, a prompt asks for the master password in order to list the platforms and users under them. Here, you can enter the password and click on `Authenticate`. If you need to recheck the password, click on the eye icon. If you do not need to enter the password while using the application, you can click on the padlock icon. However, note that you must enter the password everytime you need to do something if this is not done. On the other hand, enabling this leaves the application open for access when it is open.

> ![Entering the Password](https://user-images.githubusercontent.com/46389631/196193196-010178f6-65a0-47d9-90a8-64ee82a653b4.png)
>
> Entering the Password

### 02. Dashboard

This will take you to the Dashboard. The dashboard lists all the passwords you have saved in the database. Loading the database takes time. You can check the progress on the status bar. Clicking on a platform reveals the usernames registered under it. Hovering over the usernames reveals the options for that username: *edit* and *delete*. Clicking on the refresh button refresh the list again. If you need to search for a keyphrase, type in the search bar. Clicking on the padlock will stop remembering the password. The `New Password` option allows a new password to be added to the database. Settings button will take you to the settings page while about page takes you to the about page.

> ![Dashboard](https://user-images.githubusercontent.com/46389631/196202056-f79f02f0-cc49-4e4a-ae51-3664a6553d38.png)
> 
> Dashboard

### 03. Add New Password

The new password dialog allows you to add a new password to your database. Clicking on the `New Password` button on the dashboard opens this option. Under this, you must specify the platform and username that this new password belongs to. The application will generate a random password automatically for your convenience. In case you need to enter your own password, you can easily do this by entering it in the password textbox. The number of characters slider allows you to specify the length of the randomly generated password. The four toggles below this correspond to *lowercase characters*, *uppercase characters*, *numerals* and *special characters*. Enabling or disabling these will include or not include each one respectively. The overall strength of thee password is shown towards the right of the length slider. Click on refresh to generate a new random password. Clicking on the copy button will copy this password to the database.

> ![New Password Dialog](https://user-images.githubusercontent.com/46389631/196214235-ce9c9f7e-aec1-4f33-9955-5d21036de37b.png)
>
> New Password Dialog

### 04. View Password

Clicking on the view button on the username on the dashboard will open the View Password dialog. It displays the stored password which can then be copied. Clicking on the dropdown button reveals more information regarding the password such as the number of characters, created date and time and strength. You can click on the copy button to copy the password and clicking on `Done` will close the window. Clicking on the edit or delete option will take you to each of them respectively.

> ![View Password Dialog](https://user-images.githubusercontent.com/46389631/196215558-74a30454-5057-498d-a7b5-52a6877d6b29.png)
>
> View Password Dialog

### 05. Edit Password

Clicking on the edit button from the view password dialog reveals the edit password dialog. Here you can edit the password to a new one. Here, you get the same options as the New Password dialog. Once done, you can click on `Edit Password` to save it to the database.

> ![Edit Password Dialog](https://user-images.githubusercontent.com/46389631/196216667-1c82bd65-55a8-4dbe-8680-6b45c558cf29.png)
>
> Edit Password Dialog

### 06. Delete Password

Clicking on delete button from username on dashboard or view password dialog will bring the delete option. Clicking on the `Delete Password` button will delete the password from the database. Be careful when choosing this option as the password will permanently be deleted from the database.

> ![Delete Password Dialog](https://user-images.githubusercontent.com/46389631/196218200-41e2bc6f-f63c-43a7-b66c-123cb686f59f.png)
>
> Delete Password Dialog

### 07. Settings Page

The settings page allow you to change settings related to the application. This can be accessed by clicking on the gear icon on the dashboard.

> ![Settings Dialog](https://user-images.githubusercontent.com/46389631/196218745-fd2f569d-0ae5-4b67-b098-6cd6640dec1f.png)
>
> Settings Dialog

The available settings are as follows.
1. Language - The language of the interface
2. Keep Me Logged In - Chooses the Keep me logged in option on application start automatically
3. *Export Credential File - Exports the credentials file for backup purposes
4. Reset Credentials - Resets the credentials file and resets the database. ⚠️
5. Default Password Length
6. Use Uppercase by Default
7. Use Numericals by Default
8. Use Special Characters by Default
9. Copy When Done - Automatically copies the password when clicking on `New Password` or `Edit Password`
10. Export Database - Exports the database to a readable text format
11. Clear Database - Clears the database ⚠️
12. Backup Database - Backup the database to a file
13. Restore Database - Restores the database from a file

Additionally, clicking on the gear icon will reset the settings to their default values. Clicking on `Done` will save and exit the dialog.

### 08. About Page

This is quite straightforward as it displays the about information for the application. These information include the License, Blog link, Copyright notice, Release notes, External links, etc.

> ![image](https://user-images.githubusercontent.com/46389631/196221701-cd6dbe4d-6667-4b79-9c8e-e7f0bbc700a1.png)
>
> About Dialog

*NOTE: The salt or password alone cannot be used to recover the data in the database. Make sure to preserve both. Also note that the application is still in the Alpha phase.*

**Under the hood information can be found in the [Muragala C# Library](https://github.com/asankaSovis/password-manager-CSharpLibrary) repo.**

## Releases

#### Version 1.0.0 Alpha *[17/10/2022]*
Based on [Password Manager (C# Library)](https://github.com/asankaSovis/password-manager-CSharpLibrary) [version 1.0.2 Alpha](https://github.com/asankaSovis/password-manager-CSharpLibrary/releases/tag/v1.0.2-alpha)
**NOTE: This is the initial release**

[Password Manager GUI Application Version 1.0.0 Alpha](https://github.com/asankaSovis/password-manager-CSharpGUI/releases/tag/v1.0.0-alpha)

> MD5: `9df9ddb957858e03cbd87874316fd657`
>
> SHA1: `6e224a92dd38839db8b8dfa035b98ddd462a7eb0`
>
> SHA256: `0e2dbbfffa2f6b4d0aad30fc3967777cb31dc8a1b51b44934bb02361d72ccd67`

[Read the Blog](https://asanka.hashnode.dev/muragala-password-manager-06)

## Fixes and Features for the Next Release
- *Suggest new features*

📝 *NOTE: Throughout the application, Passcode refers to the root password set for the password manager and Password refers to the password of the application.*

`© 2022 Asanka Sovis`
