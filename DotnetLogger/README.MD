### 踩坑指南

AssemblyInfo.cs 文件中需要引入 log4net.config 配置文件，ConfigFile 项填写的是 log4net.config 相对于项目根路径的地址。

AssemblyInfo.cs 文件的属性配置中，必须将 【复制到输出目录】设置成【始终复制】或者【如果较新则复制】。曾经因为这个问题瞎折腾了一天。

log4net.config 文件的配置属性中，同样地，必须将 【复制到输出目录】设置成【始终复制】或者【如果较新则复制】。

log4net.config 文件中的 logger name 的值必须和 LoggerHelper 文件中 【LogManager.GetLogger("LogError")】或者 

【LogManager.GetLogger("LogInfo")】中的参数 LogError/LogInfo 保持一致。

