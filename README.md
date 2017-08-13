一个简单的ARP发包器
===
ARPPacketSender一个基于[SharpPcap](https://github.com/chmorgan/sharppcap)框架的简单的ARP发包器，你可以自定义一个ARP报文的以太网帧头的源MAC地址，目的MAC地址。ARP帧的相应字段，包括源MAC地址，目的MAC地址和源IP地址，目的IP地址，构造一个ARP包并发送出去。

默认情况下，ARPPacketSender自动将本机的IPv4地址填入源主机IP地址字段中，将本机的MAC地址填入源MAC地址字段中。当然，你可以根据自己的需求更改这些字段的内容。

你可以自定义发包间隔，ARPPacketSender会记录发包个数。

本发包器是为了某计算机网络实验匆促完成，功能非常简单，对填入的字段并没有进行格式校验。

ARPPacketSender基于[SharpPcap](https://github.com/chmorgan/sharppcap)框架，在使用之前你需要安装[SharpPcap](https://github.com/chmorgan/sharppcap)以及[Winpcap](https://github.com/wireshark/winpcap).

---

A simple ARP packet sender
===
ARPPacketSender is a simple ARP packet sender based on the [SharpPcap](https://github.com/chmorgan/sharppcap) framework.

