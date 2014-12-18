// Copyright 2007-2014 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Tests.Serialization
{
    using System;
    using System.IO;
    using MassTransit.Serialization;


    public class SerializationSpecificationBase<TSerializer>
        where TSerializer : IMessageSerializer, new()
    {
        Uri _destinationUri;
        Uri _faultUri;
        Uri _responseUri;
        int _retryCount;
        Uri _sourceUri;

        protected void TestSerialization<T>(T message)
            where T : class
        {
            byte[] data;
            var serializer = new TSerializer();

            _sourceUri = new Uri("loopback://localhost/source");
            _responseUri = new Uri("loopback://localhost/response");
            _faultUri = new Uri("loopback://localhost/fault");
            _destinationUri = new Uri("loopback://localhost/destination");
            _retryCount = 69;

            using (var output = new MemoryStream())
            {
//            	ISendContext<T> context = message.ToSendContext();
//				context.SetSourceAddress(_sourceUri);
//				context.SendResponseTo(_responseUri);
//				context.SendFaultTo(_faultUri);
//				context.SetDestinationAddress(_destinationUri);
//				context.SetRetryCount(_retryCount);
//
//            	serializer.Serialize(output, context);
//
//                data = output.ToArray();
            }

            // Trace.WriteLine(Encoding.UTF8.GetString(data));

//            using (MemoryStream input = new MemoryStream(data))
            {
//				IReceiveContext context = OldReceiveContext.FromBodyStream(input);
//				serializer.Deserialize(context);
//
//				IConsumeContext<T> messageContext;
//				context.TryGetContext<T>(out messageContext).ShouldBe(true);
//
//				messageContext.ShouldNotBe(null);
//            	message.Equals(messageContext.Message).ShouldBe(true);
//				message.ShouldNotBeTheSameAs(messageContext.Message);
//

//				Assert.AreEqual(_retryCount, context.RetryCount);
//				Assert.AreEqual(_sourceUri, context.SourceAddress);
//				Assert.AreEqual(_responseUri, context.ResponseAddress);
//				Assert.AreEqual(_faultUri, context.FaultAddress);
//				Assert.AreEqual(_destinationUri, context.DestinationAddress);
                //			Assert.AreEqual(message.GetType().ToMessageName(), CurrentMessage.Headers.MessageType);
            }
        }
    }
}