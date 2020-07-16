# Description  

This project uses as assembly reference this repository: https://github.com/ClaudiuBrandusa/Github-Like-Procedural-Avatar  
In simple terms, this API generates avatar images at runtime without saving them on the local storage.

# Tools used:
- Visual Studio 2019
- ASP.NET Core 3.1

# How to use?  

You have to access the following link in order to generate an image: ~/api/avatar/get , where ~ is the server address
For another generation you have to reload the page.  
You can give it different resolution for the image by assinging values to the width and height parameters in the link address 
(for example: If we want to get an image with the resolution 1000x1000px then we will use the following link ~/api/avatar/get?width=1000&height=1000)

# Constraints
- The width and height values should be between 10 and 10000 px. 

# In the end
This repo is still under development so let me know if you encounter any problems or if you have a more efficient approach. 
