## .NET Core and T4 Templates for generating code

Hi, I'm working on a project right now where I need to take a JPG image and then generate some code that is based on the image.

So for this project I will need to:
- create a console application
- take an image file as input and parse it in
- export a formatted text file based on the image and on a code template

In this post, I will walk you through how I decided to do this with .NET Core and T4 Templates and I'll give you a sample project to play around with.

To get started, you'll need the latest version of .NET Core.
https://www.microsoft.com/net/learn/get-started/windows

From here, you can either work with the command line directly to create a console application by using the "dotnet new" command or you can use Visual Studio Community https://www.visualstudio.com/downloads/ or Visual Studio Code https://code.visualstudio.com/download to create the project.  I'll be using VS community for this post.

In order to read the command line arguments into the app, I decided to go with this CommandLineParser Nuget package from here:  https://github.com/commandlineparser/commandline

In order to read the image file I found a great post here on the .NET Blog that offers several good options:    https://blogs.msdn.microsoft.com/dotnet/2017/01/19/net-core-image-processing/

I chose to go with the ImageSharp project from here … https://github.com/SixLabors/ImageSharp mainly because I liked how it uses all managed code so it should then run anywhere.

In order to format and export the file you can create a .tt template in Visual Studio by using Add Item > C# > General > RuntimeTextTemplate > RuntimeTextTemplate.tt.  To read more about T4 templates you can go here … https://docs.microsoft.com/en-us/visualstudio/modeling/run-time-text-generation-with-t4-text-templates. 
(I had trouble running this in .NET Core until I realized that the Custom Tool property is not set to TextTemplatingFilePreprocessor automatically, so you'll need to set that yourself first too)


A working sample that you can play around with is here on github. 

### Usage
```<language>
dotnet DotnetT4.dll -i t.jpg -o t.txt
```

Let me know in the comments below if you have any questions on how this works and I'll be glad to help you out in the comments.

Thanks for reading!

--Andy

