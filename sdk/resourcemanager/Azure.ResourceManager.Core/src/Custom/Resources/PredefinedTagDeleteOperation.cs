﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The operation type for the delete API. </summary>
    public partial class PredefinedTagDeleteOperation : Operation
    {
        private readonly OperationOrResponseInternals _operation;

        /// <summary> Initializes a new instance of PreDefinedTagDeleteOperation for mocking. </summary>
        protected PredefinedTagDeleteOperation()
        {
        }

        internal PredefinedTagDeleteOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationOrResponseInternals(clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PreDefinedTagDeleteOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
