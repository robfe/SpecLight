using SpecLight.Infrastructure;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace SpecLight
{
#pragma warning disable 1573
#pragma warning disable 1998
    public partial class Spec
    {

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given(Action action)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given(Action action)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync(Func<Task> action)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{}), () => action(), null, action, new object[]{});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1>(Func<T1, Task> action, T1 p1)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1}), () => action(p1), null, action, new object[]{p1});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), () => action(p1, p2), null, action, new object[]{p1, p2});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), () => action(p1, p2, p3), null, action, new object[]{p1, p2, p3});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), () => action(p1, p2, p3, p4), null, action, new object[]{p1, p2, p3, p4});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), () => action(p1, p2, p3, p4, p5), null, action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), () => action(p1, p2, p3, p4, p5, p6), null, action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }



        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Given<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Given<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec GivenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), () => action(p1, p2, p3, p4, p5, p6, p7), null, action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When(Action action)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When(Action action)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync(Func<Task> action)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{}), () => action(), null, action, new object[]{});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1>(Func<T1, Task> action, T1 p1)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1}), () => action(p1), null, action, new object[]{p1});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), () => action(p1, p2), null, action, new object[]{p1, p2});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), () => action(p1, p2, p3), null, action, new object[]{p1, p2, p3});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), () => action(p1, p2, p3, p4), null, action, new object[]{p1, p2, p3, p4});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), () => action(p1, p2, p3, p4, p5), null, action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), () => action(p1, p2, p3, p4, p5, p6), null, action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec When<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.When<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec WhenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), () => action(p1, p2, p3, p4, p5, p6, p7), null, action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then(Action action)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then(Action action)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync(Func<Task> action)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{}), () => action(), null, action, new object[]{});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1>(Func<T1, Task> action, T1 p1)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1}), () => action(p1), null, action, new object[]{p1});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), () => action(p1, p2), null, action, new object[]{p1, p2});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), () => action(p1, p2, p3), null, action, new object[]{p1, p2, p3});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), () => action(p1, p2, p3, p4), null, action, new object[]{p1, p2, p3, p4});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), () => action(p1, p2, p3, p4, p5), null, action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), () => action(p1, p2, p3, p4, p5, p6), null, action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec Then<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.Then<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec ThenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), () => action(p1, p2, p3, p4, p5, p6, p7), null, action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And(Action action)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And(Action action)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{}), async () => action(), () => action(), action, new object[]{});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync(Func<Task> action)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{}), () => action(), null, action, new object[]{});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1>(Action<T1> action, T1 p1)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1}), async () => action(p1), () => action(p1), action, new object[]{p1});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1>(Func<T1, Task> action, T1 p1)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1}), () => action(p1), null, action, new object[]{p1});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), async () => action(p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2}), () => action(p1, p2), null, action, new object[]{p1, p2});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), async () => action(p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3}), () => action(p1, p2, p3), null, action, new object[]{p1, p2, p3});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), async () => action(p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4}), () => action(p1, p2, p3, p4), null, action, new object[]{p1, p2, p3, p4});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), async () => action(p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5}), () => action(p1, p2, p3, p4, p5), null, action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), async () => action(p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6}), () => action(p1, p2, p3, p4, p5, p6), null, action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public Spec And<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec IAsyncSpec.And<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), async () => action(p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        public IAsyncSpec AndAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, new object[]{p1, p2, p3, p4, p5, p6, p7}), () => action(p1, p2, p3, p4, p5, p6, p7), null, action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }


    }

    public partial interface IAsyncSpec
    {

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given(Action action);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync(Func<Task> action);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1>(Action<T1> action, T1 p1);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1>(Func<T1, Task> action, T1 p1);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Given<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec GivenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When(Action action);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync(Func<Task> action);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1>(Action<T1> action, T1 p1);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1>(Func<T1, Task> action, T1 p1);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec When<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec WhenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then(Action action);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync(Func<Task> action);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1>(Action<T1> action, T1 p1);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1>(Func<T1, Task> action, T1 p1);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec Then<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec ThenAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And(Action action);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync(Func<Task> action);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1>(Action<T1> action, T1 p1);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1>(Func<T1, Task> action, T1 p1);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2>(Action<T1, T2> action, T1 p1, T2 p2);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2>(Func<T1, T2, Task> action, T1 p1, T2 p2);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2, T3>(Action<T1, T2, T3> action, T1 p1, T2 p2, T3 p3);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2, T3>(Func<T1, T2, T3, Task> action, T1 p1, T2 p2, T3 p3);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 p1, T2 p2, T3 p3, T4 p4);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> action, T1 p1, T2 p2, T3 p3, T4 p4);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec And<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        /// <summary>
        /// Add an additional Given, When or Then clause
        /// </summary>
        /// <remarks>
        /// Be sure to describe the behaviour not the implementation.
        /// This overload infers its text from the name of the parameter <paramref name="action"/>
        /// </remarks>
        /// <param name="action">
        /// A descriptively named method that should be run to fulfil this story fragment. The method's name will be used as the description for this fragment, once converted from CamelCase
        /// Any underscores in the method's name will be used as placeholders and will be replaced with the <see cref="object.ToString"/> of each respective argument.
        /// Do not use a lambda or anonymous method here, as the name will not be human readable
        /// </param>
        IAsyncSpec AndAsync<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

    }
#pragma warning restore 1573
#pragma warning restore 1998

}

