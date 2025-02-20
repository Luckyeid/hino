﻿using SkeletonApi.Shared.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SkeletonApi.Shared
{
    public class Result<T> : IResult<T>
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }
        public T Data { get; set; }
        public List<string> Messages { get; set; } = new List<string>();

        #region Non Async Methods 

        #region Success Methods 

        public static Result<T> Success()
        {
            return new Result<T>
            {
                Status = true
            };
        }

        public static Result<T> Success(string message)
        {
            return new Result<T>
            {
                Status = true,
                Messages = new List<string> { message }
            };
        }

        public static Result<T> Success(T data)
        {
            return new Result<T>
            {
                Status = true,
                Data = data
            };
        }

        public static Result<T> Success(T data, string message)
        {
            return new Result<T>
            {
                Status = true,
                Messages = new List<string> { message },
                Data = data
            };
        }

        #endregion

        #region Failure Methods 

        public static Result<T> Failure()
        {
            return new Result<T>
            {
                Status = false
            };
        }

        public static Result<T> Failure(string message)
        {
            return new Result<T>
            {
                Status = false,
                Messages = new List<string> { message }
            };
        }

        public static Result<T> Failure(List<string> messages)
        {
            return new Result<T>
            {
                Status = false,
                Messages = messages
            };
        }

        public static Result<T> Failure(T data)
        {
            return new Result<T>
            {
                Status = false,
                Data = data
            };
        }

        public static Result<T> Failure(T data, string message)
        {
            return new Result<T>
            {
                Status = false,
                Messages = new List<string> { message },
                Data = data
            };
        }

        public static Result<T> Failure(T data, List<string> messages)
        {
            return new Result<T>
            {
                Status = false,
                Messages = messages,
                Data = data
            };
        }

        #endregion

        #endregion

        #region Async Methods 

        #region Success Methods 

        public static Task<Result<T>> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public static Task<Result<T>> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static Task<Result<T>> SuccessAsync(T data)
        {
            return Task.FromResult(Success(data));
        }

        public static Task<Result<T>> SuccessAsync(T data, string message)
        {
            return Task.FromResult(Success(data, message));
        }

        #endregion

        #region Failure Methods 

        public static Task<Result<T>> FailureAsync()
        {
            return Task.FromResult(Failure());
        }

        public static Task<Result<T>> FailureAsync(string message)
        {
            return Task.FromResult(Failure(message));
        }

        public static Task<Result<T>> FailureAsync(List<string> messages)
        {
            return Task.FromResult(Failure(messages));
        }

        public static Task<Result<T>> FailureAsync(T data)
        {
            return Task.FromResult(Failure(data));
        }

        public static Task<Result<T>> FailureAsync(T data, string message)
        {
            return Task.FromResult(Failure(data, message));
        }

        public static Task<Result<T>> FailureAsync(T data, List<string> messages)
        {
            return Task.FromResult(Failure(data, messages));
        }

        #endregion

        #endregion
    }
}