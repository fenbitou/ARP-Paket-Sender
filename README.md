## 一个简单的ARP包发包器
ARPPacketSender一个基于SharpPcap框架的简单的ARP包发包器，你可以手动填入ARP包的IP帧头的源MAC地址，目的MAC地址。ARP包的相应字段，包括源MAC地址，目的MAC地址和源IP地址，目的IP地址。

默认情况下，ARPPacketSender将自动将本机的IPv4地址填入源主机IP地址中，将本机的MAC地址自动填入源MAC地址中。当然，你可以根据自己的需求更改这些字段的内容。

你可以自定义发包间隔，ARPPacketSender会记录法宝个数。

ARPPacketSender基于[SharpPcap](https://github.com/chmorgan/sharppcap)框架，在使用之前你需要安装[SharpPcap](https://github.com/chmorgan/sharppcap)以及[Winpcap](https://github.com/wireshark/winpcap).