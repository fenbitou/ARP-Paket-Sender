一个简单的ARP发包器
===
ARPPacketSender是一个基于[SharpPcap](https://github.com/chmorgan/sharppcap)框架的简单的ARP发包器。  
你可以自定义一个ARP报文的主要字段，构造并连续发送ARP包。

默认情况下，发包器会将本机的IPv4地址和MAC地址填入源主机的相应字段中。  
你还可以自定义发包间隔，它会记录发包个数。

本发包器是为了某计算机网络实验匆促完成，功能非常简单，对填入的字段并没有进行格式校验。

ARPPacketSender基于[SharpPcap](https://github.com/chmorgan/sharppcap)框架，在使用之前你需要安装[SharpPcap](https://github.com/chmorgan/sharppcap)以及[Winpcap](https://github.com/wireshark/winpcap).

---

A simple ARP packet sender
===
ARPPacketSender is a simple ARP packet sender based on the [SharpPcap](https://github.com/chmorgan/sharppcap) framework.

