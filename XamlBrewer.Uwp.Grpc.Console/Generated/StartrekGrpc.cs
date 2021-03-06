// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: startrek.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Startrek {
  /// <summary>
  /// Transporter Room API
  /// </summary>
  public static partial class Transporter
  {
    static readonly string __ServiceName = "Startrek.Transporter";

    static readonly grpc::Marshaller<global::Startrek.Location> __Marshaller_Startrek_Location = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Startrek.Location.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Startrek.LifeForm> __Marshaller_Startrek_LifeForm = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Startrek.LifeForm.Parser.ParseFrom);

    static readonly grpc::Method<global::Startrek.Location, global::Startrek.LifeForm> __Method_BeamUp = new grpc::Method<global::Startrek.Location, global::Startrek.LifeForm>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BeamUp",
        __Marshaller_Startrek_Location,
        __Marshaller_Startrek_LifeForm);

    static readonly grpc::Method<global::Startrek.Location, global::Startrek.LifeForm> __Method_BeamUpParty = new grpc::Method<global::Startrek.Location, global::Startrek.LifeForm>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "BeamUpParty",
        __Marshaller_Startrek_Location,
        __Marshaller_Startrek_LifeForm);

    static readonly grpc::Method<global::Startrek.LifeForm, global::Startrek.Location> __Method_BeamDown = new grpc::Method<global::Startrek.LifeForm, global::Startrek.Location>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BeamDown",
        __Marshaller_Startrek_LifeForm,
        __Marshaller_Startrek_Location);

    static readonly grpc::Method<global::Startrek.LifeForm, global::Startrek.Location> __Method_BeamDownParty = new grpc::Method<global::Startrek.LifeForm, global::Startrek.Location>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "BeamDownParty",
        __Marshaller_Startrek_LifeForm,
        __Marshaller_Startrek_Location);

    static readonly grpc::Method<global::Startrek.LifeForm, global::Startrek.LifeForm> __Method_ReplaceParty = new grpc::Method<global::Startrek.LifeForm, global::Startrek.LifeForm>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ReplaceParty",
        __Marshaller_Startrek_LifeForm,
        __Marshaller_Startrek_LifeForm);

    static readonly grpc::Method<global::Startrek.Location, global::Startrek.Location> __Method_Lock = new grpc::Method<global::Startrek.Location, global::Startrek.Location>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Lock",
        __Marshaller_Startrek_Location,
        __Marshaller_Startrek_Location);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Startrek.StartrekReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Transporter</summary>
    public partial class TransporterClient : grpc::ClientBase<TransporterClient>
    {
      /// <summary>Creates a new client for Transporter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransporterClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Transporter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransporterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransporterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransporterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Beam up a single life form from a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.LifeForm BeamUp(global::Startrek.Location request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamUp(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam up a single life form from a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.LifeForm BeamUp(global::Startrek.Location request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BeamUp, null, options, request);
      }
      /// <summary>
      /// Beam up a single life form from a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.LifeForm> BeamUpAsync(global::Startrek.Location request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamUpAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam up a single life form from a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.LifeForm> BeamUpAsync(global::Startrek.Location request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BeamUp, null, options, request);
      }
      /// <summary>
      /// Beam up a party of life forms to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Startrek.LifeForm> BeamUpParty(global::Startrek.Location request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamUpParty(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam up a party of life forms to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Startrek.LifeForm> BeamUpParty(global::Startrek.Location request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_BeamUpParty, null, options, request);
      }
      /// <summary>
      /// Beam down a single life form, and return the location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.Location BeamDown(global::Startrek.LifeForm request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamDown(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam down a single life form, and return the location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.Location BeamDown(global::Startrek.LifeForm request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BeamDown, null, options, request);
      }
      /// <summary>
      /// Beam down a single life form, and return the location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.Location> BeamDownAsync(global::Startrek.LifeForm request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamDownAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam down a single life form, and return the location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.Location> BeamDownAsync(global::Startrek.LifeForm request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BeamDown, null, options, request);
      }
      /// <summary>
      /// Beam up a party of life forms, and return the location.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Startrek.LifeForm, global::Startrek.Location> BeamDownParty(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BeamDownParty(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Beam up a party of life forms, and return the location.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Startrek.LifeForm, global::Startrek.Location> BeamDownParty(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_BeamDownParty, null, options);
      }
      /// <summary>
      /// Replace a beamed down party of life forms by another.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Startrek.LifeForm, global::Startrek.LifeForm> ReplaceParty(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReplaceParty(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Replace a beamed down party of life forms by another.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Startrek.LifeForm, global::Startrek.LifeForm> ReplaceParty(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ReplaceParty, null, options);
      }
      /// <summary>
      /// For the sake of completeness: lock the beam to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.Location Lock(global::Startrek.Location request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Lock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// For the sake of completeness: lock the beam to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Startrek.Location Lock(global::Startrek.Location request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Lock, null, options, request);
      }
      /// <summary>
      /// For the sake of completeness: lock the beam to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.Location> LockAsync(global::Startrek.Location request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// For the sake of completeness: lock the beam to a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Startrek.Location> LockAsync(global::Startrek.Location request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Lock, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransporterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransporterClient(configuration);
      }
    }

  }
}
#endregion
