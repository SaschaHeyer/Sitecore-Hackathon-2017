# Sitecore Experience Accelerator Drag-and-drop Form Composer | Build with ❤

* **Module Purpose:** Build a better user experience for editors who building forms with Sitecore and Sitecore Experience Accelerator
* **Module Sitecore Hackathon Category:** Sitecore Experience Accelerator

## Youtube
https://youtu.be/VS9DVUodXUQ

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
* Sending mails based on the Form information
* Multiple receiver mail adresses
* Success Message
* Error Message

### Components

#### Form Container [![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/workbox.png?token=AB5j8LSrx3dANnS3v4Lr7t9NNoQ6TlIsks5Yw_6UwA%3D%3D)]()
> The form container have to contain all the form related components.
Your are able to set the mail-subject and mail-receiver via experience button on this component.

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
* Upload the package and click next
*(you can find the package here https://github.com/SaschaHeyer/Sitecore-Hackathon-2017/tree/master/installation)*
* During the installation you the following message **/sitecore/content/Applications/WebEdit/Custom Experience Buttons/Edit Form**. Choose **Side-by-Side** as option, click apply.
(*see screen*)
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/installtion1.png?token=AB5j8AcKx7e-ZtTdCCfizFFupXd1lZrsks5YxE0PwA%3D%3D)]('mailConfiguration')

* Wait until the installation is done.


### 2. Create a Tenant
* Bevor you can create a Site you need to create a Tentant of your choice

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/createTenant.png?token=AB5j8LEsIT3pGKtjzmcmHEJoob5DrKAgks5YxCjZwA%3D%3D)]('mailConfiguration')

### 3. Create a Site underneath your Tenant by enabling the required Features
* Forms (Hackathon)
* Mail (Hackathon)
* *dont close the dialog yet, until you proceed the next step*

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/featureSelection.png?token=AB5j8MatUX41x2xW3rM7P1q_hvNTTqVSks5Yw_sVwA%3D%3D)]('featureSelection')


### 4. IMPORTANT STEP: disable the default Form Feature
> we need to disable the default sxa **Form** Feature

* dont close the dialog yet, until you proceed the next step

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/disableForm.png?token=AB5j8DZ-Orz6-S5XYNkLMO040IX5EoXeks5YxGDgwA%3D%3D)]('featureSelection')

### 5. Switch to the Theme Tab 
* **dont** check the *create new theme checkbox*
* select the existing Hackathon Theme

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/theme.png?token=AB5j8M_QjhLZ6JXA69pEgAfenWRl_k7hks5YxGP7wA%3D%3D)]('mailConfiguration')

### 6. Enable the Theme

> The Theme includes important javascript for the form, this is a important step.

* Add a new page unter your home root item
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/page.png?token=AB5j8FJo0PCVDjSVpfOtGf4Qsyiej8gvks5YxG86wA%3D%3D)]('mailConfiguration')

* Open this page in the Experience Editor
* In the Ribbon open the Tab Experience Accelerator
* Click on the button Theme
* selecht the Hackathon Theme and click ok
* save
* Theme setup done

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Theme1.png?token=AB5j8PdlXkmOaHGZIyG-Kx6LNC0_0CaHks5YxGtbwA%3D%3D)]('mailConfiguration')
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/Theme2.png?token=AB5j8A2Gs7JMYWIHkV7T1DEmWjEr1drYks5YxGtcwA%3D%3D)]('mailConfiguration')


### 7. Set the Mailserver Settings proper
* Go to the Settings Item and create a new **Mail Configuration** above the Mail Setting
* Set the Mail Configuration (Server, From, Username, Password, Port, SSL)

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/mailConfiguration.png?token=AB5j8LqRwU99_E8WtQaBAHL1cWEj-rFPks5Yw_s2wA%3D%3D)]('mailConfiguration')

### 8. Set the default mail settings
* It is possible to add multiple mail setting items, but you have to define one default setting which is used
* Click on **Mail** and select the your previous created mail setting item

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/selecht%20default%20mail.png?token=AB5j8BhGklXXTiZGIknmmuJLTa7w3QWKks5YxGffwA%3D%3D)]('mailConfiguration')

### 9. Done


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

### 5. Add the componentes which you need for your form you can choose between different form components
* Checkbox
* Date
* Textarea
* Text
* Email *(Inbuild validation for email adresses)**
* Password
* Submit Button *(The Submit Button triggers the mail action)*

> add this components by simply drag & drop the into the **FormContainer**

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor5.png?token=AB5j8Gk-hkJ859s5rWvSKZAGse_IO1A5ks5YxDJbwA%3D%3D)]()

### 6. Mandatory Fields
* The Fields are support mandatory validation with mandatory Message
* This option is aviable via Content Fields
* Click on one of your Input Components and select **Edit Field**
* By enable the checkbox **Mandatory** the mandatory validation is enabled
* The **Mandatory Error Message** is predefined, you can change it if you want

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor6_1.png)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor7_1.png)]()

> If you send your form, without filling the mandatory fields you receive the following message above each form component.

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/error%20message.png?token=AB5j8LIJuDW0xGfQuVBQgleGbvk-NVKKks5YxHQzwA%3D%3D)]()

### 7. Key
* All submitted fields support the choice of a special key
* The Key is later used to determine each single field [key=value]
* Note: Duplicated key are not allowed. If you use a key twice one of the fields is not transmitted to the server
* This option is aviable via Content Fields
* Click on one of your Input Components and select **Edit Field**
* Initially the **Key** is the name of the field, but can be changed in any other value

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor6_1.png)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor6_1_1.png)]()

### 7. Styling
* All Form Components are Style enabled
* This option is aviable via Rendering Paramters
* Click on one of your Input Components and select **Edit component properties**
* Scroll down to the Styling Section
* Choose one of the Stylings for example **Position Center** and click ok

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor6.png?token=AB5j8FYNrE6NKiM6xV_bS0lnMnTs-y1cks5YxDJkwA%3D%3D)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor8.png?token=AB5j8AGwxlGuq1wOUyg3dVNvjBImp5vpks5YxDROwA%3D%3D)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor9.png?token=AB5j8JeqowFmXtXiaSYWnwN6Db00fUeCks5YxDRVwA%3D%3D)]()

### 8. Mail Format Settings

> The mail format ist predefined, if you want you can change the default behavior. You have to provide all of this three informations, otherwiese a fallback is used.

* Select the **FormContainer** and click on the **Edit component form Item** Custom Experience button
* You have change the following fields (Opening, Closing, Field Format)

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor3.png?token=AB5j8GA2EzWr0PknPwwPg0jQ9VEPwAf0ks5YxDJKwA%3D%3D)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor10.png?token=AB5j8LTvXcwqccnPJIceYznB2qY_bmfJks5YxDt4wA%3D%3D)]()

### 9. Success and Fail Message

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/success.png?token=AB5j8M8LzYbSNZohaK1gA9hc1bA5p4pKks5YxHXGwA%3D%3D)]()


* The form provides the option to edit success and error messages
* Select the **FormContainer** and click on the **Edit component form Item** Custom Experience button
* you can edit both message´s with a default RTE Field

[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/experienceEditor3.png?token=AB5j8GA2EzWr0PknPwwPg0jQ9VEPwAf0ks5YxDJKwA%3D%3D)]()
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/success%20error.png?token=AB5j8CkElG4tBXwjCUuGEi8VLdQjv0Efks5YxHWBwA%3D%3D)]()

## Extensibility and Developer Informations

### Item Structure

#### Placeholders
* /sitecore/layout/Placeholder Settings/Feature/Experience Accelerator/Hackathon

#### Renderings
* /sitecore/layout/Renderings/Feature/Experience Accelerator/Hackathon

#### Templates
* /sitecore/templates/Feature/Experience Accelerator/Hackathon
* /sitecore/templates/Foundation/Experience Accelerator/Mail

#### Settings
* /sitecore/system/Settings/Feature/Experience Accelerator/Hackathon
* /sitecore/system/Settings/Foundation/Experience Accelerator/Mail

#### Branches
* /sitecore/templates/Branches/Feature/Experience Accelerator/Hackathon

#### Custom Experience Buttons (**CORE** Database)
* /sitecore/content/Applications/WebEdit/Custom Experience Buttons/Edit Form

## Knowing Issues
### Duplicated Field Labels cause Issues
* In this version of this feature please prevent duplicated field labels with the same name. 

## Team

[Marina Gluzberg](https://www.linkedin.com/in/marina-gluzberg-a5707840/) | [Sascha Heyer](http://blog.saschaheyer.de) | [Christian Hahn](https://hachweb.wordpress.com)

## Final Sample
[![](https://raw.githubusercontent.com/SaschaHeyer/Sitecore-Hackathon-2017/master/documentation/formsample.png?token=AB5j8NbkIUpv-sLxkpBB40MjI1pg6j-Xks5YxHktwA%3D%3D)]()


## License 
MIT License

Copyright (c) 2017 Sascha Heyer, Marina Gluzberg, Christian Hahn
