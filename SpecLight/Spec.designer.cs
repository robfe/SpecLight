using System;
using System.Linq.Expressions;

namespace SpecLight
{
#pragma warning disable 1573
    public partial class Spec
    {

        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method), action, action, new object[0]);
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1), () => action(p1), action, new object[]{p1});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }


        /// <summary>
        /// The given part describes the state of the world before you begin the behavior you're specifying in this scenario (like Arrange in AAA). The purpose of givens is to put the system in a known state before the user (or external system) starts interacting with the system (in the When steps). Avoid talking about user interaction in givens. If you had worked with usecases, you would call this preconditions.
        /// 
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
        public Spec Given<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            AddStep(ScenarioBlock.Given, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7, p8), () => action(p1, p2, p3, p4, p5, p6, p7, p8), action, new object[]{p1, p2, p3, p4, p5, p6, p7, p8});
            return this;
        }



        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method), action, action, new object[0]);
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1), () => action(p1), action, new object[]{p1});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }


        /// <summary>
        /// What are the behaviours that happen to the SUT that we want to specify (Act). The purpose of When steps is to describe the key action the user performs (or, using Robert C. Martin’s metaphor, the state transition).
        /// 
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
        public Spec When<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            AddStep(ScenarioBlock.When, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7, p8), () => action(p1, p2, p3, p4, p5, p6, p7, p8), action, new object[]{p1, p2, p3, p4, p5, p6, p7, p8});
            return this;
        }



        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method), action, action, new object[0]);
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1), () => action(p1), action, new object[]{p1});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }


        /// <summary>
        /// The then section describes the changes you expect due to the specified behavior (Assert). The purpose of Then steps is to observe outcomes. The observations should be related to the business value/benefit in your feature description. The observations should also be on some kind of output – that is something that comes out of the system (report, user interface, message) and not something that is deeply buried inside it (that has no business value).
        /// 
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
        public Spec Then<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            AddStep(ScenarioBlock.Then, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7, p8), () => action(p1, p2, p3, p4, p5, p6, p7, p8), action, new object[]{p1, p2, p3, p4, p5, p6, p7, p8});
            return this;
        }



        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method), action, action, new object[0]);
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1), () => action(p1), action, new object[]{p1});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2), () => action(p1, p2), action, new object[]{p1, p2});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3), () => action(p1, p2, p3), action, new object[]{p1, p2, p3});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3, p4), () => action(p1, p2, p3, p4), action, new object[]{p1, p2, p3, p4});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5), () => action(p1, p2, p3, p4, p5), action, new object[]{p1, p2, p3, p4, p5});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6), () => action(p1, p2, p3, p4, p5, p6), action, new object[]{p1, p2, p3, p4, p5, p6});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7), () => action(p1, p2, p3, p4, p5, p6, p7), action, new object[]{p1, p2, p3, p4, p5, p6, p7});
            return this;
        }


        /// <summary>
        /// Add an additional Given, When or Then clause
        /// 
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
        public Spec And<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            AddStep(ScenarioBlock.And, StringHelpers.CreateText(action.Method, p1, p2, p3, p4, p5, p6, p7, p8), () => action(p1, p2, p3, p4, p5, p6, p7, p8), action, new object[]{p1, p2, p3, p4, p5, p6, p7, p8});
            return this;
        }


    }
#pragma warning restore 1573

}

