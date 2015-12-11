# Lab | Hello World .NET Application on Linux

[![License](https://img.shields.io/github/license/odaceo/lab-hello-world-dotnet-linux.svg)](LICENSE)

## Description

A simple .NET application on Linux.

## Prerequisites

[Vagrant](https://www.vagrantup.com/downloads.html) must be installed on your 
computer to mount the workbench for this project.

Open a Terminal and run the following commands:

```shell
vagrant up
vagrant ssh
cd /vagrant
```

## Restoring dependencies

The restore command download dependencies specified in the .NET project.

``` shell
dotnet restore
```

## Compiling the application

The compile command makes a standalone binary file.

``` shell
dotnet compile --configuration Release --native
```

## Running the application

To launch the application use the following command:

``` shell
bin/Release/dnxcore50/Hello World
```

## Releasing the application

Step-by-step instructions for releasing the application:

1. Start a new release

        git flow release start x.y.z

1. Finish the release

        git flow release finish -m "Release x.y.z" x.y.z

## Reporting Issues

Issues can be reported at [https://github.com/odaceo/lab-hello-world-dotnet-linux/issues](https://github.com/odaceo/lab-hello-world-dotnet-linux/issues)

## Source code

The source code is available at [https://github.com/odaceo/lab-hello-world-dotnet-linux](https://github.com/odaceo/lab-hello-world-dotnet-linux)

## License

All the source code is distributed under [ASL 2.0](LICENSE).

## Copyright

© 2015 [Odaceo](http://odaceo.ch). All rights reserved.
