# Notification system for ZTZBX Framework

### **Requirements**
- [core-ztzbx](https://github.com/ZTZBX/core-ztzbx)


To edit it, open `notification.sln` in Visual Studio.

To build it, run `build.cmd`. To run it, run the following commands to make a symbolic link in your server data directory:

```dos
cd /d [PATH TO THIS RESOURCE]
mklink /d X:\cfx-server-data\resources\[local]\notification dist
```

Afterwards, you can use `ensure notification` in your server.cfg or server console to start the resource.

### **Client Side**
**Send notification**
```cs
// first paramenter is header
// secoud parameter is the sender
// third parameter is the body message
Exports["notification"].send("Header", "Sender", "Body");

// example

Exports["notification"].send("Dear " + Exports["core-ztzbx"].playerUsername(), "Banker - Central Bank", "If you already have an account, you can't create another one.");
```


### **Server Side**
**Send notification**
```cs
// the same at the client part but the first parameter is the username of the user
Exports["notification"].send("username","Header", "Sender", "Body");

// example
playerUsername = // call client event ho trigger this export Exports["core-ztzbx"].playerUsername() and pass to the function first parameter

Exports["notification"].send(playerUsername, "Dear " + playerUsername, "Banker - Central Bank", "If you already have an account, you can't create another one.");
```
---

*The result of the example:*

![](https://github.com/ZTZBX/notification/blob/main/example_of_notification.png)
