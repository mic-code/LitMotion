using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;
using LitMotion.Extensions;

namespace LitMotion.Tests.Runtime
{
    public class TransformTest
    {
        Transform target;
        const float Duration = 1f;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            target = new GameObject("Target").transform;
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Object.Destroy(target.gameObject);
        }

        [UnityTest]
        public IEnumerator Test_BindToPosition()
        {
            var endValue = Vector3.one;
            yield return LMotion.Create(Vector3.zero, endValue, Duration).BindToPosition(target).ToYieldInteraction();
            Assert.That(target.position, Is.EqualTo(endValue).Using(Vector3EqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToPositionX()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToPositionX(target).ToYieldInteraction();
            Assert.That(target.position.x, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToPositionY()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToPositionY(target).ToYieldInteraction();
            Assert.That(target.position.y, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToPositionZ()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToPositionZ(target).ToYieldInteraction();
            Assert.That(target.position.z, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalPosition()
        {
            var endValue = Vector3.one;
            yield return LMotion.Create(Vector3.zero, endValue, Duration).BindToLocalPosition(target).ToYieldInteraction();
            Assert.That(target.localPosition, Is.EqualTo(endValue).Using(Vector3EqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalPositionX()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalPositionX(target).ToYieldInteraction();
            Assert.That(target.localPosition.x, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalPositionY()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalPositionY(target).ToYieldInteraction();
            Assert.That(target.localPosition.y, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalPositionZ()
        {
            var endValue = 10f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalPositionZ(target).ToYieldInteraction();
            Assert.That(target.localPosition.z, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToRotation()
        {
            var endValue = Quaternion.Euler(10f, 20f, 30f);
            yield return LMotion.Create(Quaternion.identity, endValue, Duration).BindToRotation(target).ToYieldInteraction();
            Assert.That(target.rotation, Is.EqualTo(endValue).Using(QuaternionEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalRotation()
        {
            var endValue = Quaternion.Euler(10f, 20f, 30f);
            yield return LMotion.Create(Quaternion.identity, endValue, Duration).BindToLocalRotation(target).ToYieldInteraction();
            Assert.That(target.localRotation, Is.EqualTo(endValue).Using(QuaternionEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToEulerAngles()
        {
            var endValue = Vector3.one * 10f;
            yield return LMotion.Create(Vector3.zero, endValue, Duration).BindToEulerAngles(target).ToYieldInteraction();
            Assert.That(target.eulerAngles, Is.EqualTo(endValue).Using(Vector3EqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToEulerAnglesX()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToEulerAnglesX(target).ToYieldInteraction();
            Assert.That(target.eulerAngles.x, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToEulerAnglesY()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToEulerAnglesY(target).ToYieldInteraction();
            Assert.That(target.eulerAngles.y, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToEulerAnglesZ()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToEulerAnglesZ(target).ToYieldInteraction();
            Assert.That(target.eulerAngles.z, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalEulerAngles()
        {
            var endValue = Vector3.one * 10f;
            yield return LMotion.Create(Vector3.zero, endValue, Duration).BindToLocalEulerAngles(target).ToYieldInteraction();
            Assert.That(target.localEulerAngles, Is.EqualTo(endValue).Using(Vector3EqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalEulerAnglesX()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToLocalEulerAnglesX(target).ToYieldInteraction();
            Assert.That(target.localEulerAngles.x, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalEulerAnglesY()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToLocalEulerAnglesY(target).ToYieldInteraction();
            Assert.That(target.localEulerAngles.y, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalEulerAnglesZ()
        {
            var endValue = 10f;
            yield return LMotion.Create(0f, endValue, Duration).BindToLocalEulerAnglesZ(target).ToYieldInteraction();
            Assert.That(target.localEulerAngles.z, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalScale()
        {
            var endValue = Vector3.one * 2f;
            yield return LMotion.Create(Vector3.one, endValue, Duration).BindToLocalScale(target).ToYieldInteraction();
            Assert.That(target.localScale, Is.EqualTo(endValue).Using(Vector3EqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalScaleX()
        {
            var endValue = 2f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalScaleX(target).ToYieldInteraction();
            Assert.That(target.localScale.x, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalScaleY()
        {
            var endValue = 2f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalScaleY(target).ToYieldInteraction();
            Assert.That(target.localScale.y, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }

        [UnityTest]
        public IEnumerator Test_BindToLocalScaleZ()
        {
            var endValue = 2f;
            yield return LMotion.Create(1f, endValue, Duration).BindToLocalScaleZ(target).ToYieldInteraction();
            Assert.That(target.localScale.z, Is.EqualTo(endValue).Using(FloatEqualityComparer.Instance));
        }
    }
}