# Net-Core-ElasticSearch-Logging
.Net Core ile ElasticSearch üzerinde loglama ve bu logları kibana üzerinden takip etme

Gerekli Kurulumlar için bilgisayarınızda docker uygulamanızı ayağa kaldırın ve alt kısımda yazanları sırası ile uygulayın.

<b>Network oluşturmak için;</b><br/>
docker network create elasticnetwork

<b>Elasticsearch image'nı bilgisayarımıza almak ve sonrasında ayağa kaldırmak için;</b><br/>
docker pull elasticsearch:7.10.1	
<br/>
docker run -d --name elasticsearch --net elasticnetwork -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" elasticsearch:7.10.1

<b>Kibana image'nı bilgisayarımıza almak ve sonrasında ayağa kaldırmak için;</b> (Kibana default olarak 9200 portunu dinlemekte)<br/>
docker pull kibana:7.10.1
<br/>
docker run -d --name kibana --net elasticnetwork -p 5601:5601 kibana:7.10.1
