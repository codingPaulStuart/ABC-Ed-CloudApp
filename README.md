# ABC-Ed-CloudApp
WCF Services application for Enrollment System

1.1 Cloud solution vs private ISP hosting – Which Option and Why
1.2 If it is a cloud service, which one – AWS, Google App Engine or Azure? (Justify your choice)

1.3 Implementation of Core Services- choices are ASP.NET Web Service, MVC, WCF service or REST? (Justify your choice)
1.5 Database deployment options- current legacy system or deployed as a cloud-based database (Think scalability and Compatibility)


Cloud hosting will be simpler to manage, open to non-web clients and provide superior adaptability to different operating systems, legacy systems, and platforms. Its only downside would be cost for hosting as well as internet speeds.
The Service will be hosted on Google App Engine because it has a good cloud processing center that will allow the various classes and functions to perform well one the cloud. It also allows data to be stored on the cloud and queries to run as well.
It has good infrastructure that can be chosen for specific needs. Cloud functions would be the best option to use because it is designed for event driven actions, such as the enrollment process. It is good because it will only run the event logic needed to process a new enrollment, rather than some of the other options that are for high traffic and users. You can choose to pay for the usage or have dedicated cloud processor reserved, which can further be customized. However, for the enrollment system there are only a handful of times during the year where it is used so to pay for it based on event driven processing would be ideal.  
WCF will be the implementation of core service because it offers the most flexibility. Its main strength is that it is useful for different applications or frameworks to talk to each other by serializing and deserializing the data with XML. It would be ideal as it essentially allows different programs to talk to each other through XML endpoints. The legacy system is built on Windows Forms in C#.NET so there is no need to explore a web-dominant rest API.

Rest would not be a good choice because it is predominantly about data sharing over the web only. If the interface/view for the legacy system was using a web site, then rest would be better as it can take advantage of all the HTTP web technologies using JSON data. However, WCF could be configured for this anyway if need.

Again, with an MVC pattern this would be better suited to a Web Based Client using JSON data. MVC would restrict the application into a pattern of controls for actions. It does not offer as good a scalability as the WCF does.
The only real concern with putting the database on the cloud would be costing and budget constraints. It would offer far greater access and versatility, only dependent on speed of internet and how much server-side processing is needed. If submitted to the cloud, there would now be much greater scalability and greater ability for different views to be created that can access the database. It would not require physical server space and would not require all the configuring and maintenance. It would assist greatly in the new system that is being deployed to the cloud.
