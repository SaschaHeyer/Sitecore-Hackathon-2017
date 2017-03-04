# Sitecore Experience Accelerator Drag-and-drop Form Editor | Build with ❤

* **Module Purpose:** Build a better user experience for editors building forms with Sitecore and Sitecore Experience Accelerator
* **Module Sitecore Hackathon Category:** Sitecore Experience Accelerator

## Prerequesites
* Sitecore 8.2 rev. 161221 (Update-2)
* Sitecore Experience Accelerator for 8.2

>(*Sitecore Experience Platform 8.2 Update 1 Works as well* ) 

## Features

### Main Features
#### Mail (Foundation Project)

#### Forms (Feature Project)
* A set of standard Form Fields
* Mandatory
* Mandatory Message
* Styles for each component can set via Rendering Parameters
* Scaffolding is predefined 
* Data Folder and Page Data Support
* Multiple receiver mail adresses

### Components

#### Form Container [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/workbox.png?token=AB5j8LSrx3dANnS3v4Lr7t9NNoQ6TlIsks5Yw_6UwA%3D%3D)]()
> The form container have to contain all the form related components.
Your are able to set the email-subject and email-receiver via experience button on this component.

#### Checkbox Input [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Right.png?token=AB5j8OAnXOkPNaB0N8YGQpCGCzHiQ3vYks5Yw_7awA%3D%3D)]()

#### Text Input [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/paint.png?token=AB5j8APN7UApqgMG8iLaSpU4GHl6RFQXks5Yw_66wA%3D%3D)]()

#### Textarea Input [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Pencil.png?token=AB5j8IJo2ENtSd1qlWE3KVZ7udK6r_a2ks5Yw_7swA%3D%3D)]()

#### Date Input [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Calendar.png?token=AB5j8BQQDs970KZPRKkGZicRQItaeCwZks5YxAx0wA%3D%3D)]()

#### Submit [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Memorycard.png?token=AB5j8AtAEhVy_o2gzgn1DLPQcKzUfvDWks5Yw_79wA%3D%3D)]()


### Benefits

* Content authors can add forms anywhere on the site
* Forms provides the best experience by manage forms fully in the Experience Editor
* Forms can be fully mixed with all other components for the best content author experience
* No special form editor required
* Forms can go through workflows

## Installation

### 1. Install the Sitecore package

### 2. Create a Tenant
* Bevor you can create a Site you need to create a Tentant of your choice

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/createTenant.png?token=AB5j8LEsIT3pGKtjzmcmHEJoob5DrKAgks5YxCjZwA%3D%3D)]('mailConfiguration')

### 3. Create a Site underneath your Tenant by enabling the required Features
* Forms (Hackathon)
* Mail (Hackathon)
* *dont close the dialog yet, until you proceed the next step*

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/featureSelection.png?token=AB5j8MatUX41x2xW3rM7P1q_hvNTTqVSks5Yw_sVwA%3D%3D)]('featureSelection')

### 4. Switch to the Theme Tab 
* enable the *Create new theme* checkbox
* choose a name of your choice
* click ok and create the Page

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/createTheme.png?token=AB5j8I_pdvtSfVTrHzwTbWenkh4sEWRMks5YxCi_wA%3D%3D)]('mailConfiguration')


### 5. Set the Mailserver Settings proper
* Go to the Settings Item and create a new **Mail Configuration** above the Mail Setting
* Set the Mail Configuration (Server, From, Username, Password, Port, SSL)

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/mailConfiguration.png?token=AB5j8LqRwU99_E8WtQaBAHL1cWEj-rFPks5Yw_s2wA%3D%3D)]('mailConfiguration')


### 6. Done


## Usage

> **Tip:** All Components can be saved in the data folder as well as page data
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/associatedContent.png?token=AB5j8IUAP56BqcNAR_0cGBbgqvZJphsSks5Yw_rOwA%3D%3D)]('associatedContent')


### 1. Open the Experience Editor
* locate and expand the Hackathon Section
* this section include alle available componentes

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor1.png?token=AB5j8JfQg2OrPZ1kdmpTyMaL7RvOkvsoks5YxDHjwA%3D%3D)]()


### 2. Start with the first component
* add the component **FormContainer** in a placeholder of your choice
* choose a data source of your choice

> This component builds the wrapper around our complete form and capsulate the components together. 
If you like you can add splitter and other moduls together with the form in this container, this enables you to build very dynamic and flexibel forms.

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor2.png?token=AB5j8ItmIlXdRlGLlCK2YidvCnVl-I9Nks5YxDJCwA%3D%3D)]()

### 3. Edit the Form Container
* after your **FormContainer** is placed click on the **Edit component form Item** Custom Experience button

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor3.png?token=AB5j8GA2EzWr0PknPwwPg0jQ9VEPwAf0ks5YxDJKwA%3D%3D)]()

### 4. Set the mail information
* on each for you are able to set different mail informations
* **Subject** of the mail 
* **To** the mail adress which receive the form data if the form is submitted

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor4.png?token=AB5j8Nzz8xzUOT8ALrvgeNalC8pZJ_sRks5YxDJSwA%3D%3D)]()

### 5. Add the componentes of which you need for your form you can choose between different form components
* Checkbox
* Date
* Textarea
* Text
* Submit Button

> add this components by simply drag & drop the into the **FormContainer**

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor5.png?token=AB5j8Gk-hkJ859s5rWvSKZAGse_IO1A5ks5YxDJbwA%3D%3D)]()

### 6. Mandatory Fields
* The Fields are support mandatory validation with mandatory Message
* This option is aviable via Rendering Paramters
* Click on one of your Input Components and select **Edit component properties**
* By enable the checkbox **Mandatory** the mandatory validation is enabled
* The **Mandatory Error Message** is predefined, you can change it if you want

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor6.png?token=AB5j8FYNrE6NKiM6xV_bS0lnMnTs-y1cks5YxDJkwA%3D%3D)]()

## Extensibility

## Team

[Marina Gluzberg](https://www.linkedin.com/in/marina-gluzberg-a5707840/) | [Sascha Heyer](http://blog.saschaheyer.de) | [Christian Hahn](https://hachweb.wordpress.com)

## License 